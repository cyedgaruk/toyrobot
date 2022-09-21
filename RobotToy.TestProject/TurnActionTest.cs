using RobotToy.Models.Actions;
using RobotToy.Models.Boards;
using RobotToy.Models;
using RobotToy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.TestProject
{
    public class TurnActionTest
    {
        (int X, int Y, Face Face) _currentPositon;
        (int Width, int Height) _dimension;

        [SetUp]
        public void Setup()
        {
            _currentPositon = (0, 0, Face.EAST);
            _dimension = (5, 5);
        }

        [Test]
        public void When_TurnLeftCommand_Expect_CorrectOrientation()
        {
            var action = new TurnAction(Direction.LEFT);

            var expectedX = 0;
            var expectedY = 0;
            var expectedFace = Face.NORTH;

            var result = action.DoAction(_currentPositon, _dimension);

            Assert.That(result.Item1, Is.EqualTo(expectedX));
            Assert.That(result.Item2, Is.EqualTo(expectedY));
            Assert.That(result.Item3, Is.EqualTo(expectedFace));
        }

        [Test]
        public void When_TurnRightCommand_Expect_CorrectOrientation()
        {
            var action = new TurnAction(Direction.RIGHT);

            var expectedX = 0;
            var expectedY = 0;
            var expectedFace = Face.SOUTH;

            var result = action.DoAction(_currentPositon, _dimension);

            Assert.That(result.Item1, Is.EqualTo(expectedX));
            Assert.That(result.Item2, Is.EqualTo(expectedY));
            Assert.That(result.Item3, Is.EqualTo(expectedFace));
        }


    }

}
