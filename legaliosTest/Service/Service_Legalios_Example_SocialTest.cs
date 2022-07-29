using FluentAssertions;
using HraveMzdy.Legalios.Service.Errors;
using HraveMzdy.Legalios.Service.Interfaces;
using LanguageExt;

namespace LegaliosTest.Service
{
    public class Service_Legalios_Example_SocialTest : Service_Legalios_Example_BaseTest
    {
        protected void ShoulBeValidBundle(Either<IHistoryResultError, IBundleProps> testResult, short resultYear, short resultMonth)
        {
            try
            {
                testResult.IsRight.Should().BeTrue();
                testResult.IfRight(r => {
                        r.Should().NotBeNull();
                        r.Should().BeAssignableTo<IBundleProps>();
                        r.PeriodProps.Year.Should().Be(resultYear);
                        r.PeriodProps.Month.Should().Be(resultMonth);
                        r.SocialProps.Should().NotBeNull();
                    });
            }
            catch (Xunit.Sdk.XunitException e)
            {
                throw e;
            }
        }
    }
}