namespace Passenger.Passengers.Models.ValueObjects;
using System;
using global::Passenger.Exceptions;

public record PassengerId
{
    public Guid Value { get; }

    private PassengerId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidPassengerIdExceptions(value);
        }

        Value = value;
    }

    public static PassengerId Of(Guid value)
    {
        return new PassengerId(value);
    }

    public static implicit operator Guid(PassengerId passengerId)
    {
        return passengerId.Value;
    }
}
