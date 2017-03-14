namespace InternetAccessCalculation
{
    public abstract class AbstrInstance
    {
        private bool isDone = false;

        protected abstract void Idle();

        protected void SetDone()
        {
            isDone = true;
        }

        protected bool Done()
        {
            return isDone;
        }

        public void Run()
        {
            while (!Done())
                Idle();
        }
    }
}
