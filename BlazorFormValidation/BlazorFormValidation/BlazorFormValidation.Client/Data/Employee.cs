using FluentValidation;

namespace BlazorFormValidation.Client.Data
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MainEmail { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string AltEmail { get; set; }
        public string City { get; set; }

    }
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator() 
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Debes ingresar un nombre");
            RuleFor(p => p.Name).MaximumLength(50).WithMessage("El nombre no debe superar 50 caracteres");
            RuleFor(p => p.Age).NotEmpty().WithMessage("Debes ingresar una edad mayor a 0");
            RuleFor(p => p.Age).LessThan(100).WithMessage("Debes ingresar una edad menor a 100");
            RuleFor(p => p.MainEmail).NotEmpty().WithMessage("Debes ingresar un Correo principal");
            RuleFor(p => p.MainEmail).EmailAddress().WithMessage("Debes ingresar un correo válido");
        }
    }
}
