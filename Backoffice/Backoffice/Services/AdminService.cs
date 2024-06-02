
using Backoffice.Data;
using Backoffice.Models;
using Microsoft.EntityFrameworkCore;

namespace Backoffice.Services;

public class AdminService(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<AdminModel>> GetAllAdminsAsync()
    {
        return await _context.Users
                             .Include(user => user.Role)
                             .Select(user => new AdminModel
                             {
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 Role = user.Role != null ? user.Role.RoleName : "No Role Assigned"
                             })
                             .ToListAsync();
    }

    public async Task UpdateAdminAsync(ApplicationUser user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAdminAsync(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}

