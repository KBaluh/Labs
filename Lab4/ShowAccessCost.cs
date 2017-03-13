using System;

namespace InternetAccessCalculation
{
    class ShowAccessCost : AbstrInstance
    {
        private AccessCost accessCost;

        public ShowAccessCost(AccessCost accessCost)
        {
            this.accessCost = accessCost;
        }

        protected override void Init()
        {
        }

        protected override void Idle()
        {
            //виведення результату
            Console.WriteLine("Загальна вартiсть заходу: {0}", accessCost.costOfAccess);
            SetDone();
        }

        protected override void CleanUp()
        {
        }            
    }
}
