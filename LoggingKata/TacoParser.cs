using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                logger.LogInfo("cells length is less than 3");
                return null; 
            }

            // grab the latitude from your array at index 0
            // grab the longitude from your array at index 1
            // grab the name from your array at index 2

            double latitude = Double.Parse(cells[0]);
            double longitute = Double.Parse(cells[1]);
            string name = cells[2];


            Point point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitute;

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int'

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            TacoBell tacobell = new TacoBell(name, point);


            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            logger.LogInfo($"{tacobell.Location.Latitude}, {tacobell.Location.Longitude} and {tacobell.Name} properly passed to tacobell class");
            return tacobell;
        }
    }
}