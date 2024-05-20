using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DTO_s;
using WebApplication1.Entities;

namespace WebApplication1.Controllers;

[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetBooks(CancellationToken cancellationToken)
    {
        ClientContext context = new();
        
      //  List<Client> clients = await context.Clients.Include(x=>x.IdClient).Select(x=> new ClientTripsDTO()).ToListAsync(cancellationToken);
      //  List<ClientTrip> clientTrips = await context.ClientTrips.Include(x =>x.IdTrip).Select(x=> new ClientDTO(x.IdClient)).ToListAsync(cancellationToken);
    //    return Ok(clientTrips);
    return Ok();
    }
    
}