using MvvmCross.ViewModels;
using MvxStarter.Core.Services;

namespace MvxStarter.Core.ViewModels
{
    public class LuckinessViewModel : MvxViewModel
    {
        readonly IPropabilityDeterminer _determiner;

        public LuckinessViewModel(IPropabilityDeterminer propabilityDeterminer)
        {
            _determiner = propabilityDeterminer;
        }

        private int _luck;

        public int Luck
        {
            get { return _luck; }
            set { _luck = value; }
        }

        private int _luckyNumber;

        public int LuckyNumber
        {
            get { return _luckyNumber; }
            set { _luckyNumber = value; }
        }


    }
}
