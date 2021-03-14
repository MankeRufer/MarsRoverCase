using HBMarsProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HBMarsProject.Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void DiscoveryTest1()
        {
            Rover roverCoordinate = new Rover()
            {
                PositionX = 1,
                PositionY = 2,
                direction = Enum.DirectionEnum.N
            };


            var directory = "LMLMLMLMM";

            roverCoordinate.MoveDiscovery(roverCoordinate, directory, 5, 5);



            var actualOutput = $"{roverCoordinate.PositionX} {roverCoordinate.PositionY} {roverCoordinate.direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
