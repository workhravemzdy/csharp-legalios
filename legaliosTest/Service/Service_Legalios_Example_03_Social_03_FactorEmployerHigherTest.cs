﻿using System;
using AutoFixture;
using FluentAssertions;
using HraveMzdy.Legalios.Service;
using HraveMzdy.Legalios.Interfaces;
using HraveMzdy.Legalios.Service.Types;
using NSubstitute;
using System.Collections.Generic;
using Xunit;
using LegaliosTests;

namespace LegaliosTest.Service
{
    [Collection("TestEngine")]
    public class Service_Legalios_Example_03_Social_03_FactorEmployerHigherTest : Service_Legalios_Example_SocialTest
    {

        private readonly IServiceLegalios _sut;

        private static readonly TestDecScenario[] _tests = new TestDecScenario[]
        {
            new TestDecScenario("2010", new TestDecParams[] {
                new TestDecParams( "2010-1", 2010, 1, 2010, 1, 0.0m ),
                new TestDecParams( "2010-2", 2010, 2, 2010, 2, 0.0m ),
                new TestDecParams( "2010-3", 2010, 3, 2010, 3, 0.0m ),
                new TestDecParams( "2010-4", 2010, 4, 2010, 4, 0.0m ),
                new TestDecParams( "2010-5", 2010, 5, 2010, 5, 0.0m ),
                new TestDecParams( "2010-6", 2010, 6, 2010, 6, 0.0m ),
                new TestDecParams( "2010-7", 2010, 7, 2010, 7, 0.0m ),
                new TestDecParams( "2010-8", 2010, 8, 2010, 8, 0.0m ),
                new TestDecParams( "2010-9", 2010, 9, 2010, 9, 0.0m ),
                new TestDecParams( "2010-10", 2010, 10, 2010, 10, 0.0m ),
                new TestDecParams( "2010-11", 2010, 11, 2010, 11, 0.0m ),
                new TestDecParams( "2010-12", 2010, 12, 2010, 12, 0.0m ),
            }),
            new TestDecScenario("2011", new TestDecParams[] {
                new TestDecParams( "2011-1", 2011, 1, 2011, 1, 26.0m ),
                new TestDecParams( "2011-2", 2011, 2, 2011, 2, 26.0m ),
                new TestDecParams( "2011-3", 2011, 3, 2011, 3, 26.0m ),
                new TestDecParams( "2011-4", 2011, 4, 2011, 4, 26.0m ),
                new TestDecParams( "2011-5", 2011, 5, 2011, 5, 26.0m ),
                new TestDecParams( "2011-6", 2011, 6, 2011, 6, 26.0m ),
                new TestDecParams( "2011-7", 2011, 7, 2011, 7, 26.0m ),
                new TestDecParams( "2011-8", 2011, 8, 2011, 8, 26.0m ),
                new TestDecParams( "2011-9", 2011, 9, 2011, 9, 26.0m ),
                new TestDecParams( "2011-10", 2011, 10, 2011, 10, 26.0m ),
                new TestDecParams( "2011-11", 2011, 11, 2011, 11, 26.0m ),
                new TestDecParams( "2011-12", 2011, 12, 2011, 12, 26.0m ),
            }),
            new TestDecScenario("2012", new TestDecParams[] {
                new TestDecParams( "2012-1", 2012, 1, 2012, 1, 26.0m ),
                new TestDecParams( "2012-2", 2012, 2, 2012, 2, 26.0m ),
                new TestDecParams( "2012-3", 2012, 3, 2012, 3, 26.0m ),
                new TestDecParams( "2012-4", 2012, 4, 2012, 4, 26.0m ),
                new TestDecParams( "2012-5", 2012, 5, 2012, 5, 26.0m ),
                new TestDecParams( "2012-6", 2012, 6, 2012, 6, 26.0m ),
                new TestDecParams( "2012-7", 2012, 7, 2012, 7, 26.0m ),
                new TestDecParams( "2012-8", 2012, 8, 2012, 8, 26.0m ),
                new TestDecParams( "2012-9", 2012, 9, 2012, 9, 26.0m ),
                new TestDecParams( "2012-10", 2012, 10, 2012, 10, 26.0m ),
                new TestDecParams( "2012-11", 2012, 11, 2012, 11, 26.0m ),
                new TestDecParams( "2012-12", 2012, 12, 2012, 12, 26.0m ),
            }),
            new TestDecScenario("2013", new TestDecParams[] {
                new TestDecParams( "2013-1", 2013, 1, 2013, 1, 26.0m ),
                new TestDecParams( "2013-2", 2013, 2, 2013, 2, 26.0m ),
                new TestDecParams( "2013-3", 2013, 3, 2013, 3, 26.0m ),
                new TestDecParams( "2013-4", 2013, 4, 2013, 4, 26.0m ),
                new TestDecParams( "2013-5", 2013, 5, 2013, 5, 26.0m ),
                new TestDecParams( "2013-6", 2013, 6, 2013, 6, 26.0m ),
                new TestDecParams( "2013-7", 2013, 7, 2013, 7, 26.0m ),
                new TestDecParams( "2013-8", 2013, 8, 2013, 8, 26.0m ),
                new TestDecParams( "2013-9", 2013, 9, 2013, 9, 26.0m ),
                new TestDecParams( "2013-10", 2013, 10, 2013, 10, 26.0m ),
                new TestDecParams( "2013-11", 2013, 11, 2013, 11, 26.0m ),
                new TestDecParams( "2013-12", 2013, 12, 2013, 12, 26.0m ),
            }),
            new TestDecScenario("2014", new TestDecParams[] {
                new TestDecParams( "2014-1", 2014, 1, 2014, 1, 26.0m ),
                new TestDecParams( "2014-2", 2014, 2, 2014, 2, 26.0m ),
                new TestDecParams( "2014-3", 2014, 3, 2014, 3, 26.0m ),
                new TestDecParams( "2014-4", 2014, 4, 2014, 4, 26.0m ),
                new TestDecParams( "2014-5", 2014, 5, 2014, 5, 26.0m ),
                new TestDecParams( "2014-6", 2014, 6, 2014, 6, 26.0m ),
                new TestDecParams( "2014-7", 2014, 7, 2014, 7, 26.0m ),
                new TestDecParams( "2014-8", 2014, 8, 2014, 8, 26.0m ),
                new TestDecParams( "2014-9", 2014, 9, 2014, 9, 26.0m ),
                new TestDecParams( "2014-10", 2014, 10, 2014, 10, 26.0m ),
                new TestDecParams( "2014-11", 2014, 11, 2014, 11, 26.0m ),
                new TestDecParams( "2014-12", 2014, 12, 2014, 12, 26.0m ),
            }),
            new TestDecScenario("2015", new TestDecParams[] {
                new TestDecParams( "2015-1", 2015, 1, 2015, 1, 0.0m ),
                new TestDecParams( "2015-2", 2015, 2, 2015, 2, 0.0m ),
                new TestDecParams( "2015-3", 2015, 3, 2015, 3, 0.0m ),
                new TestDecParams( "2015-4", 2015, 4, 2015, 4, 0.0m ),
                new TestDecParams( "2015-5", 2015, 5, 2015, 5, 0.0m ),
                new TestDecParams( "2015-6", 2015, 6, 2015, 6, 0.0m ),
                new TestDecParams( "2015-7", 2015, 7, 2015, 7, 0.0m ),
                new TestDecParams( "2015-8", 2015, 8, 2015, 8, 0.0m ),
                new TestDecParams( "2015-9", 2015, 9, 2015, 9, 0.0m ),
                new TestDecParams( "2015-10", 2015, 10, 2015, 10, 0.0m ),
                new TestDecParams( "2015-11", 2015, 11, 2015, 11, 0.0m ),
                new TestDecParams( "2015-12", 2015, 12, 2015, 12, 0.0m ),
            }),
            new TestDecScenario("2016", new TestDecParams[] {
                new TestDecParams( "2016-1", 2016, 1, 2016, 1, 0.0m ),
                new TestDecParams( "2016-2", 2016, 2, 2016, 2, 0.0m ),
                new TestDecParams( "2016-3", 2016, 3, 2016, 3, 0.0m ),
                new TestDecParams( "2016-4", 2016, 4, 2016, 4, 0.0m ),
                new TestDecParams( "2016-5", 2016, 5, 2016, 5, 0.0m ),
                new TestDecParams( "2016-6", 2016, 6, 2016, 6, 0.0m ),
                new TestDecParams( "2016-7", 2016, 7, 2016, 7, 0.0m ),
                new TestDecParams( "2016-8", 2016, 8, 2016, 8, 0.0m ),
                new TestDecParams( "2016-9", 2016, 9, 2016, 9, 0.0m ),
                new TestDecParams( "2016-10", 2016, 10, 2016, 10, 0.0m ),
                new TestDecParams( "2016-11", 2016, 11, 2016, 11, 0.0m ),
                new TestDecParams( "2016-12", 2016, 12, 2016, 12, 0.0m ),
            }),
            new TestDecScenario("2017", new TestDecParams[] {
                new TestDecParams( "2017-1", 2017, 1, 2017, 1, 0.0m ),
                new TestDecParams( "2017-2", 2017, 2, 2017, 2, 0.0m ),
                new TestDecParams( "2017-3", 2017, 3, 2017, 3, 0.0m ),
                new TestDecParams( "2017-4", 2017, 4, 2017, 4, 0.0m ),
                new TestDecParams( "2017-5", 2017, 5, 2017, 5, 0.0m ),
                new TestDecParams( "2017-6", 2017, 6, 2017, 6, 0.0m ),
                new TestDecParams( "2017-7", 2017, 7, 2017, 7, 0.0m ),
                new TestDecParams( "2017-8", 2017, 8, 2017, 8, 0.0m ),
                new TestDecParams( "2017-9", 2017, 9, 2017, 9, 0.0m ),
                new TestDecParams( "2017-10", 2017, 10, 2017, 10, 0.0m ),
                new TestDecParams( "2017-11", 2017, 11, 2017, 11, 0.0m ),
                new TestDecParams( "2017-12", 2017, 12, 2017, 12, 0.0m ),
            }),
            new TestDecScenario("2018", new TestDecParams[] {
                new TestDecParams( "2018-1", 2018, 1, 2018, 1, 0.0m ),
                new TestDecParams( "2018-2", 2018, 2, 2018, 2, 0.0m ),
                new TestDecParams( "2018-3", 2018, 3, 2018, 3, 0.0m ),
                new TestDecParams( "2018-4", 2018, 4, 2018, 4, 0.0m ),
                new TestDecParams( "2018-5", 2018, 5, 2018, 5, 0.0m ),
                new TestDecParams( "2018-6", 2018, 6, 2018, 6, 0.0m ),
                new TestDecParams( "2018-7", 2018, 7, 2018, 7, 0.0m ),
                new TestDecParams( "2018-8", 2018, 8, 2018, 8, 0.0m ),
                new TestDecParams( "2018-9", 2018, 9, 2018, 9, 0.0m ),
                new TestDecParams( "2018-10", 2018, 10, 2018, 10, 0.0m ),
                new TestDecParams( "2018-11", 2018, 11, 2018, 11, 0.0m ),
                new TestDecParams( "2018-12", 2018, 12, 2018, 12, 0.0m ),
            }),
            new TestDecScenario("2019", new TestDecParams[] {
                new TestDecParams( "2019-1", 2019, 1, 2019, 1, 0.0m ),
                new TestDecParams( "2019-2", 2019, 2, 2019, 2, 0.0m ),
                new TestDecParams( "2019-3", 2019, 3, 2019, 3, 0.0m ),
                new TestDecParams( "2019-4", 2019, 4, 2019, 4, 0.0m ),
                new TestDecParams( "2019-5", 2019, 5, 2019, 5, 0.0m ),
                new TestDecParams( "2019-6", 2019, 6, 2019, 6, 0.0m ),
                new TestDecParams( "2019-7", 2019, 7, 2019, 7, 0.0m ),
                new TestDecParams( "2019-8", 2019, 8, 2019, 8, 0.0m ),
                new TestDecParams( "2019-9", 2019, 9, 2019, 9, 0.0m ),
                new TestDecParams( "2019-10", 2019, 10, 2019, 10, 0.0m ),
                new TestDecParams( "2019-11", 2019, 11, 2019, 11, 0.0m ),
                new TestDecParams( "2019-12", 2019, 12, 2019, 12, 0.0m ),
            }),
            new TestDecScenario("2020", new TestDecParams[] {
                new TestDecParams( "2020-1", 2020, 1, 2020, 1, 0.0m ),
                new TestDecParams( "2020-2", 2020, 2, 2020, 2, 0.0m ),
                new TestDecParams( "2020-3", 2020, 3, 2020, 3, 0.0m ),
                new TestDecParams( "2020-4", 2020, 4, 2020, 4, 0.0m ),
                new TestDecParams( "2020-5", 2020, 5, 2020, 5, 0.0m ),
                new TestDecParams( "2020-6", 2020, 6, 2020, 6, 0.0m ),
                new TestDecParams( "2020-7", 2020, 7, 2020, 7, 0.0m ),
                new TestDecParams( "2020-8", 2020, 8, 2020, 8, 0.0m ),
                new TestDecParams( "2020-9", 2020, 9, 2020, 9, 0.0m ),
                new TestDecParams( "2020-10", 2020, 10, 2020, 10, 0.0m ),
                new TestDecParams( "2020-11", 2020, 11, 2020, 11, 0.0m ),
                new TestDecParams( "2020-12", 2020, 12, 2020, 12, 0.0m ),
            }),
            new TestDecScenario("2021", new TestDecParams[] {
                new TestDecParams( "2021-1", 2021, 1, 2021, 1, 0.0m ),
                new TestDecParams( "2021-2", 2021, 2, 2021, 2, 0.0m ),
                new TestDecParams( "2021-3", 2021, 3, 2021, 3, 0.0m ),
                new TestDecParams( "2021-4", 2021, 4, 2021, 4, 0.0m ),
                new TestDecParams( "2021-5", 2021, 5, 2021, 5, 0.0m ),
                new TestDecParams( "2021-6", 2021, 6, 2021, 6, 0.0m ),
                new TestDecParams( "2021-7", 2021, 7, 2021, 7, 0.0m ),
                new TestDecParams( "2021-8", 2021, 8, 2021, 8, 0.0m ),
                new TestDecParams( "2021-9", 2021, 9, 2021, 9, 0.0m ),
                new TestDecParams( "2021-10", 2021, 10, 2021, 10, 0.0m ),
                new TestDecParams( "2021-11", 2021, 11, 2021, 11, 0.0m ),
                new TestDecParams( "2021-12", 2021, 12, 2021, 12, 0.0m ),
            }),
            new TestDecScenario("2022", new TestDecParams[] {
                new TestDecParams( "2022-1", 2022, 1, 2022, 1, 0.0m ),
                new TestDecParams( "2022-2", 2022, 2, 2022, 2, 0.0m ),
                new TestDecParams( "2022-3", 2022, 3, 2022, 3, 0.0m ),
                new TestDecParams( "2022-4", 2022, 4, 2022, 4, 0.0m ),
                new TestDecParams( "2022-5", 2022, 5, 2022, 5, 0.0m ),
                new TestDecParams( "2022-6", 2022, 6, 2022, 6, 0.0m ),
                new TestDecParams( "2022-7", 2022, 7, 2022, 7, 0.0m ),
                new TestDecParams( "2022-8", 2022, 8, 2022, 8, 0.0m ),
                new TestDecParams( "2022-9", 2022, 9, 2022, 9, 0.0m ),
                new TestDecParams( "2022-10", 2022, 10, 2022, 10, 0.0m ),
                new TestDecParams( "2022-11", 2022, 11, 2022, 11, 0.0m ),
                new TestDecParams( "2022-12", 2022, 12, 2022, 12, 0.0m ),
            }),
        };
        public static IEnumerable<object[]> TestData => GetTestDecData(_tests);
        public Service_Legalios_Example_03_Social_03_FactorEmployerHigherTest()
        {
            _sut = new ServiceLegalios();
#if __PROTOKOL_TEST_FILE__
            //03_Social_03_FactorEmployerHigher
            LogTestExamples("03_Social_03_FactorEmployerHigher.txt", _tests);
#endif
        }
        [Theory]
        [MemberData(nameof(TestData))]
        public void GetBundle_ShouldReturnValid_FactorEmployerHigher(string testTitle, string testName, Int16 testYear, Int16 testMonth, Int16 resultYear, Int16 resultMonth, Decimal resultValue)
        {
            var testPeriod = new Period(testYear, testMonth);

            var testResult = _sut.GetBundle(testPeriod);

            ShoulBeValidBundle(testResult, resultYear, resultMonth);

            testResult.Match(
                Left: ex => ex.Should().BeNull(),
                Right: r => r.SocialProps.FactorEmployerHigher.Should().Be(resultValue, "Because Period: {0} - {1}", testTitle, testName));
        }
    }
}
