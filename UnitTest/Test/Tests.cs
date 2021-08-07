using Measurement_Converter_Library.DTOs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [Category("Boundries")]
        public void TestInputBoundryMainPageCorrect()
        {
            Assert.IsFalse(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyMainPage('1'));
        }

        [Test]
        [Category("Boundries")]
        public void TestInputBoundryMainPageFalse()
        {
            Assert.IsTrue(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyMainPage('A'));
        }

        [Test]
        [Category("Boundries")]
        public void TestInputBoundryEndPageCorrect()
        {
            Assert.IsFalse(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyEndPage('1'));
        }

        [Test]
        [Category("Boundries")]
        public void TestInputBoundryEndPageFalse()
        {
            Assert.IsTrue(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyEndPage('A'));
        }

        [Test]
        [Category("Boundries")]
        public void TestInputBoundryValueInputCorrect()
        {
            Assert.IsFalse(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsValueToCalculateFaulty("120"));
        }

        [Test]
        [Category("Boundries")]
        public void TestInputBoundryValueInputFalse()
        {
            Assert.IsTrue(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsValueToCalculateFaulty("ASD"));
        }


        [Test]
        [Category("Logging")]
        public void TestInputBoundryValueInputTrue()
        {
            Assert.IsTrue(Measurement_Converter_Library.BoundryChecks.FaultCheck.IsValueToCalculateFaulty("ASD"));
        }

        [Test]
        [Category("Logging")]
        public static void TestWriteCalculationLog()
        {
            LoggingObj log = new LoggingObj();
            log.Calculation = "100 : Meter To Inch : ";
            log.Date = DateTime.Now.ToString();
            Assert.DoesNotThrow(() => Measurement_Converter_Library.Logging.ConsoleLogging.WriteCalculationLog(log));
        }

        [Test]
        [Category("Logging")]
        public static void TestWriteErrorLog()
        {
            ErrorLoggingObj log = new ErrorLoggingObj();
            log.Error = "TestException : ";
            log.Date = DateTime.Now.ToString();
            Assert.DoesNotThrow(() => Measurement_Converter_Library.Logging.ConsoleLogging.WriteErrorLog(log));
        }

        [Test]
        [Category("Conversions")]
        public static void TestMeterToCentimeter()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToCentimeterConversion(100);
            Assert.IsTrue(value == 100 * 100);
        }

        [Test]
        [Category("Conversions")]
        public static void TestCentimeterToMeter()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMeterConversion(100);
            Assert.IsTrue(value == 100 / 100);
        }


        [Test]
        [Category("Conversions")]
        public static void TestCentimeterToMillimeter()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMillimeterConversion(100);
            Assert.IsTrue(value == 100 * 10);
        }

        [Test]
        [Category("Conversions")]
        public static void TestMillimeterToCentimeter()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.MillimeterToCentimeterConversion(100);
            Assert.IsTrue(value == 100 / 10);
        }

        [Test]
        [Category("Conversions")]
        public static void TestMeterToInch()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToInchConversion(100);
            Assert.IsTrue(value == 100 * 39.37);
        }

        [Test]
        [Category("Conversions")]
        public static void TestInchToMeter()
        {
            var value = Measurement_Converter_Library.Methods.MeasurementConversions.InchToMeterConversion(100);
            Assert.IsTrue(value == 100 / 39.37);
        }
    }
}
