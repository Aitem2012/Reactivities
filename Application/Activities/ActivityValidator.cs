using Domain;
using FluentValidation;

namespace Application.Activities
{
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator()
        {
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Category).NotEmpty();
            RuleFor(e => e.City).NotEmpty();
            RuleFor(e => e.Date).NotEmpty();
            RuleFor(e => e.Description).NotEmpty();
            RuleFor(e => e.Venue).NotEmpty();

        }
    }
}