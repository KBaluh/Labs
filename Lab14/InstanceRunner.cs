namespace InternetAccessCalculation
{
    class InstanceRunner
    {
        private InterfaceInstance itsInstance = null;

        public InstanceRunner(InterfaceInstance instance)
        {
            itsInstance = instance;
        }

        public void Run()
        {
            itsInstance.Init();
            while (!itsInstance.Done())
                itsInstance.Idle();
            itsInstance.CleanUp();
        }
    }
}
