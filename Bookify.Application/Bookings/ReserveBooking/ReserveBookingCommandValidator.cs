using FluentValidation;

namespace Bookify.Application.Bookings.ReserveBooking;

public class ReserveBookingCommandValidator : AbstractValidator<ReserveBookingCommand>
{
    public ReserveBookingCommandValidator()
    {
        RuleFor(c => c.UserId).NotEmpty().WithMessage("UserId should not be empty");

        RuleFor(c => c.ApartmentId).NotEmpty().WithMessage("ApartmentId should not be empty");

        RuleFor(c => c.StartDate).LessThan(c => c.EndDate).WithMessage("StartDate must be less than EndDate");
    }
}