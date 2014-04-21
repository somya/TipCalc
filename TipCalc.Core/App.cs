using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;

namespace TipCalc.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
//            CreatableTypes()
//                .EndingWith("Service")
//                .AsInterfaces()
//                .RegisterAsLazySingleton();

			Mvx.RegisterType<ICalculation, Calculation>();
				
			RegisterAppStart<TipViewModel>();
        }
    }
}