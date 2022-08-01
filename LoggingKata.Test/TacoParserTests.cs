using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", -86.503055)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", -86.889051)]
        [InlineData("33.49763,-86.875722,Taco Bell Birmingham...", -86.875722)]
        [InlineData("34.784434,-84.771556,Taco Bell Chatswort...", -84.771556)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tester = new TacoParser();

            //Act
            ITrackable actual = tester.Parse(line);

            //Assert
            Assert.Equal(actual.Location.Longitude, expected);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", 34.324462)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", 33.556383)]
        [InlineData("33.49763,-86.875722,Taco Bell Birmingham...", 33.49763)]
        [InlineData("34.784434,-84.771556,Taco Bell Chatswort...", 34.784434)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tester = new TacoParser();

            //Act
            ITrackable actual = tester.Parse(line);

            //Assert
            Assert.Equal(actual.Location.Latitude, expected);
        }
    }
}
