using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.DTO
{
    public class ArtistCreateDto
    {
        public string Name { get; set; }
        public string Poster { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
    public class ArtistCreateDtoValidator : AbstractValidator<ArtistCreateDto>
    {
        public ArtistCreateDtoValidator()
        {

            RuleFor(a => a.Name).NotEmpty().MaximumLength(50).WithMessage("Ad maximum 50 xarakter ola bilər");
            RuleFor(a => a.Name).NotEmpty().MaximumLength(500).WithMessage("Desc maximum 500 xarakter ola bilər");

        }
    }
}
