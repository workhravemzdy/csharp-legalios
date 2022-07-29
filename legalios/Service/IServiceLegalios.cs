using HraveMzdy.Legalios.Service.Interfaces;
using HraveMzdy.Legalios.Service.Errors;
using LanguageExt;

namespace HraveMzdy.Legalios.Service
{
    public interface IServiceLegalios
    {
        Either<IHistoryResultError, IBundleProps> GetBundle(IPeriod period);
    }
}
