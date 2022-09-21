using RobotToy.Models;
using RobotToy.Models.Actions;
using RobotToy.Models.Boards;
using RobotToy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.TestProject
{
    public class RobotMoverTest
    {
        private ToyRobot _robot;
        private Board _board;

        private RobotMover _robotMover;

        [SetUp]
        public void Setup()
        {
            _robot = new ToyRobot();
            _board = new SquareBoard();
            _robotMover = new RobotMover(_robot, _board);
        }

        [Test]
        public void When_FirstCommandIsPlace_Expect_CorrectPositoin()
        {
            var action = new PlaceAction(2, 2, Face.EAST);

            var expectedX = 2;
            var expectedY = 2;
            var expectedFace = Face.EAST;
            var expectedIsPlaced = true;

            _robotMover.Execute(action);

            Assert.That(_robot.X, Is.EqualTo(expectedX));
            Assert.That(_robot.Y, Is.EqualTo(expectedY));
            Assert.That(_robot.Face, Is.EqualTo(expectedFace));
            Assert.That(_robot.IsPlaced, Is.EqualTo(expectedIsPlaced));
        }

        [Test]
        public void When_FirstCommandIsNotPlace_Expect_RemainPosition()
        {
            var action = new MoveAction();

            var expectedX = 0;
            var expectedY = 0;
            var expectedFace = Face.EAST;
            var expectedIsPlaced = false;

            _robotMover.Execute(action);

            Assert.That(_robot.X, Is.EqualTo(expectedX));
            Assert.That(_robot.Y, Is.EqualTo(expectedY));
            Assert.That(_robot.Face, Is.EqualTo(expectedFace));
            Assert.That(_robot.IsPlaced, Is.EqualTo(expectedIsPlaced));
        }

    }
}
