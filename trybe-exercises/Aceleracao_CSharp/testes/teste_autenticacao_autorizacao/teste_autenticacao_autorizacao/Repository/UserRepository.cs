namespace teste_autenticacao_autorizacao.Repository;

using teste_autenticacao_autorizacao.Models;
using teste_autenticacao_autorizacao.Context;

public class UserRepository : IUserRepository
{

  private readonly IDatabaseContext _context;
  public UserRepository(IDatabaseContext context)
  {
    _context = context;
  }

  public User Add(User user)
  {
    _context.Users.Add(user);
    _context.SaveChanges();
    return user;
  }

  public User? GetUserByEmail(string email)
  {
    User? existingUser = _context.Users.Where(u => u.Email == email).FirstOrDefault();
    return existingUser;
  }
}
