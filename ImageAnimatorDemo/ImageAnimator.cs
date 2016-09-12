using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;

namespace Kstudio.Forms
{
    public class ImageAnimator : IDisposable
    {

        #region Private Fields

        private System.Timers.Timer animationTimer;
        private readonly List<Image> imagesList;
        private int currentFrame;
        private bool directionForward = true;
        private bool isStopped = true;
        private AsyncOperation asyncOperation;

        #endregion Private Fields



        #region Constructors

        public ImageAnimator()
        {
            animationTimer = new System.Timers.Timer();
            imagesList = new List<Image>();
            animationTimer.Elapsed += animationTimer_Elapsed;
            FramesPerSecond = 24;
        }

        #endregion Constructors


        #region Publc Properties

        /// <summary>
        /// Type of animation: Loop, PingPong or Reverse
        /// </summary>
        public AnimationType Type
        {
            get;
            set;
        }

        public double FramesPerSecond
        {
            get
            {
                double frames = 1000 / animationTimer.Interval;
                return frames;
            }
            set
            {
                animationTimer.Interval = 1000 / value;
            }
        }

        #endregion Publc Properties



        #region Publc Methods

        public event EventHandler<ImageAnimatorEventArgs> UpdateFrame;

        public void AddImages(List<Image> images, bool clear = false)
        {
            bool restart = animationTimer.Enabled;
            int lastFrame = currentFrame;
            if (restart)
            {
                Stop();
            }

            if (clear)
            {
                foreach (var image in imagesList)
                    image.Dispose();
            }
            if (images != null)
            {
                foreach (var image in images.Where(image => image != null))
                {
                    imagesList.Add(image);
                }
            }
            if (restart)
                Start(lastFrame);
        }

        public void Start(int startFrame = 0)
        {
            isStopped = false;
            animationTimer.Stop();
            currentFrame = startFrame;
            if (asyncOperation == null)
                asyncOperation = AsyncOperationManager.CreateOperation(null);
            OnFrameChanged(Type);
        }

        public void Stop()
        {
            isStopped = true;
            animationTimer.Stop();
        }


        public void PrevFrame()
        {
            Stop();
            if (directionForward)
            {
                if (currentFrame == 0)
                    currentFrame = MaxFrames - 1;
                else
                    currentFrame -= 2;
                if (currentFrame < 0)
                    currentFrame = MaxFrames;
            }
            directionForward = false;
            OnFrameChanged(AnimationType.Reverse);
        }

        public void NextFrame()
        {
            Stop();
            if (!directionForward)
            {
                if (currentFrame == MaxFrames)
                    currentFrame = 1;
                else
                    currentFrame += 2;
                if (currentFrame > MaxFrames)
                    currentFrame = 0;
            }
            directionForward = true;
            OnFrameChanged(AnimationType.Loop);
        }

        public void Dispose()
        {
            Stop();
            foreach (var image in imagesList)
                image.Dispose();

            imagesList.Clear();
            if (animationTimer != null)
            {
                animationTimer.Dispose();
                animationTimer = null;
            }
        }

        ~ImageAnimator()
        {
            Dispose();
        }

        #endregion Publc Methods


        #region Private Methods

        private void animationTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isStopped)
                animationTimer.Stop();
            else
                OnFrameChanged(Type);
        }

        private void OnFrameChanged(object arg)
        {
            var handler = UpdateFrame;
            var e = arg as ImageAnimatorEventArgs;
            if (handler != null && e != null)
            {
                handler(this, e);
            }
        }

        private void OnFrameChanged(AnimationType type)
        {
            animationTimer.Stop();
            if (imagesList.Count < 2)
                return;

            if (UpdateFrame != null)
            {
                var arg = new ImageAnimatorEventArgs(imagesList[currentFrame], currentFrame);
                if (asyncOperation != null)
                    this.asyncOperation.Post(OnFrameChanged, arg);
            }
            SetNextFrame(type);
            if (!isStopped)
                animationTimer.Start();
        }

        private void SetNextFrame(AnimationType type)
        {
            int maxFrames = MaxFrames;
            switch (type)
            {
                case AnimationType.Loop:
                    if (currentFrame < maxFrames)
                        currentFrame++;
                    else
                        currentFrame = 0;
                    break;

                case AnimationType.PinPong:
                    if (directionForward && currentFrame < maxFrames)
                    {
                        currentFrame++;
                    }
                    else if (currentFrame > 0)
                    {
                        currentFrame--;
                        directionForward = currentFrame == 0;
                    }
                    else if (currentFrame < maxFrames)
                        currentFrame++;
                    else
                    {
                        currentFrame--;
                        directionForward = currentFrame == 0;
                    }
                    break;

                case AnimationType.Reverse:
                    directionForward = false;
                    if (currentFrame == 0)
                        currentFrame = maxFrames;
                    else
                        currentFrame--;
                    break;

                default:
                    break;
            }
        }

        private int MaxFrames
        {
            get { return imagesList.Count - 1; }
        }

        #endregion Private Methods

        public class ImageAnimatorEventArgs : EventArgs
        {
            public ImageAnimatorEventArgs(Image image, int frame)
            {
                Image = image;
                Frame = frame;
            }

            public Image Image
            {
                get;
                private set;
            }

            public int Frame
            {
                get;
                private set;
            }
        }

        public enum AnimationType
        {
            Loop,
            PinPong,
            Reverse
        }
    }
}
