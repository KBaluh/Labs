namespace InternetAccessCalculation
{
    public abstract class AbstrInstance : InterfaceInstance
    {
        private bool isDone = false;

        public abstract void Idle();

        public bool Done()
        {
            return isDone;
        }

        public void Run()
        {
            while (!Done())
                Idle();
        }

        public void Init()
        {
        }

        public void CleanUp()
        {
        }

        protected void SetDone()
        {
            isDone = true;
        }
    }
}
