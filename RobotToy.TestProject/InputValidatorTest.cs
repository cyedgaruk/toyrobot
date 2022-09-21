using RobotToy.Models;
using RobotToy.Models.Actions;
using RobotToy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.TestProject
{
    public class InputValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_PlaceCommand_Expect_PlaceAction()
        {
            var input = "PLACE 1,1,NORTH";

            var expectedType = typeof(PlaceAction);

            var obj = InputValidator.Validate(input);

            Assert.AreEqual(expectedType, obj.GetType());
        }

        [Test]
        public void When_PlaceCommand_Expect_CorrectParams()
        {
            var input = "PLACE 1,1,NORTH";

            var expectX = 1;
            var expectY = 1;
            var expectFace = Face.NORTH;

            var obj = InputValidator.Validate(input);

            Assert.That(((PlaceAction)obj).X, Is.EqualTo(expectX));
            Assert.That(((PlaceAction)obj).Y, Is.EqualTo(expectY));
            Assert.That(((PlaceAction)obj).Face, Is.EqualTo(expectFace));
        }


        [Test]
        public void When_MoveCommand_Expect_MoveAction()
        {
            var input = "MOVE";

            var expectedType = typeof(MoveAction);

            var obj = InputValidator.Validate(input);

            Assert.That(obj.GetType(), Is.EqualTo(expectedType));
        }

        [Test]
        public void When_TurnCommand_Expect_TurnAction()
        {
            var input = "LEFT";

            var expectedType = typeof(TurnAction);

            var obj = InputValidator.Validate(input);

            Assert.That(obj.GetType(), Is.EqualTo(expectedType));
        }

        [Test]
        public void When_TurnCommand_Expect_CorrectDirection()
        {
            var input = "LEFT";

            var expectedValue = Direction.LEFT;

            var obj = InputValidator.Validate(input);

            Assert.That(((TurnAction)obj).Direction, Is.EqualTo(expectedValue));
        }

        [Test]
        public void When_ReportCommand_Expect_ReportAction()
        {
            var input = "REPORT";

            var expectedType = typeof(ReportAction);

            var obj = InputValidator.Validate(input);

            Assert.That(obj.GetType(), Is.EqualTo(expectedType));
        }


        [Test]
        public void When_OtherCommand_Expect_InvalidAction()
        {
            var input = "TEST";

            var expectedType = typeof(InvalidAction);

            var obj = InputValidator.Validate(input);

            Assert.That(obj.GetType(), Is.EqualTo(expectedType));
        }

    }
}
