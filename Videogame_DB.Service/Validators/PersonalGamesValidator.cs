using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videogame_DB.Domain.Entities;

namespace Videogame_DB.Service.Validators
{
    public class PersonalGamesValidator : AbstractValidator<PersonalGames>
    {
        public PersonalGamesValidator()
        {
            RuleFor(c => c.GameName)
                .NotEmpty().WithMessage("Please enter the game name.")
                .NotNull().WithMessage("Please enter the game name.");

            RuleFor(c => c.StartPlay)
                .NotEmpty().WithMessage("Please enter the date that you started playing.")
                .NotNull().WithMessage("Please enter the date that you started playing.");

            RuleFor(c => c.EndPlay)
                .NotEmpty().WithMessage("Please enter the date that you ended playing.")
                .NotNull().WithMessage("Please enter the date that you ended playing.");
        }
    }
}
