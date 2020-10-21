using FluentValidation;
using StudentDataAccess.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleSystem.Validators
{
    public class StudentValidator : AbstractValidator<IStudent>
    {
        private readonly IStudentRepository studentRepository;

        public StudentValidator(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;

            RuleFor(s => s.StudentId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Student ID is Empty")
                .Length(8).WithMessage("Student ID Length must be 8")
                .Must(BeValidUNCStundentIdFormat).WithMessage("Student ID Format must be xx-xxxxx, all numbers")
                .MustAsync(BeUniqueStudentID).WithMessage("Student Id Already Exists");

            RuleFor(s => s.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("{PropertyName} length must be from 2 and 50")
                .Must(NotContainDigits).WithMessage("{PropertyName} must not contain numbers");

            RuleFor(s => s.MiddleName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("{PropertyName} length must be from 2 and 50")
                .Must(NotContainDigits).WithMessage("{PropertyName} must not contain numbers");

            RuleFor(s => s.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("{PropertyName} length must be from 2 and 50")
                .Must(NotContainDigits).WithMessage("{PropertyName} must not contain numbers");

            RuleFor(s => s.Course)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("{PropertyName} length must be from 2 and 50")
                .Must(NotContainDigits).WithMessage("{PropertyName} must not contain numbers");

            RuleFor(s => s.YearLevel)
                .Cascade(CascadeMode.Stop)
                .Must(BeAValidYearLevel).WithMessage("Year Level must be from 1 to 4 only");
        }

        private bool BeAValidYearLevel(int yearLevel)
        {
            return yearLevel >= 1 || yearLevel <= 4;
        }

        private bool BeValidUNCStundentIdFormat(string studentId)
        {
            var isValidUNCStudentIDNumber = false;

            for (int i = 0; i < studentId.Length; i++)
            {
                if (i == 2)
                    continue;

                if (Char.IsDigit(studentId[i]))
                    isValidUNCStudentIDNumber = true;
                else
                    return false;
            }

            return isValidUNCStudentIDNumber && studentId[2] == '-';
        }

        private bool NotContainDigits(string name)
        {
            name = name.Replace("-", "").Trim();

            foreach (char character in name)
            {
                if (Char.IsDigit(character))
                    return false;
            }

            return true;
        }

        private async Task<bool> BeUniqueStudentID(string studentId, CancellationToken token)
        {
            var student = await studentRepository.GetIndividualStudent(studentId);

            return student == null;
        }

    }
}
