using System;
using HraveMzdy.Legalios.Service.Errors;
using HraveMzdy.Legalios.Factories;
using HraveMzdy.Legalios.Interfaces;
using HraveMzdy.Legalios.Service.Interfaces;
using LanguageExt;
using static LanguageExt.Prelude;

namespace HraveMzdy.Legalios.Service
{
    public class ServiceLegalios : IServiceLegalios
    {
        public ServiceLegalios()
        {
            Builder = new BundleBuilder();
        }

        private IBundleBuilder Builder { get; }

        public Either<IHistoryResultError, IBundleProps> GetBundle(IPeriod period)
        {
            var resultBundle = Builder.GetBundle(period);
            if (resultBundle == null)
            {
                return HistoryResultError.CreateBundleNoneError();
            }
            if (resultBundle.PeriodProps.Code == 0)
            {
                return HistoryResultError.CreateBundleEmptyError();
            }
            if (resultBundle.PeriodProps.Code < period.Code)
            {
                return HistoryResultError.CreateBundleInvalidError();
            }
            return Right(resultBundle);
        }
    }
}
