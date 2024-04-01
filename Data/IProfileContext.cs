using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public interface IProfileContext
    {
        DbSet<Profile> Profiles { get; }
    }
}
