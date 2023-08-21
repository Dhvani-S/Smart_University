using Microsoft.AspNetCore.Mvc;
using PlacecomBackend.Models; // Make sure to add the correct namespace for your DbContext

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetPaginatedStudents(int page, int pageSize)
    {
        var startIndex = (page - 1) * pageSize;
        var students = _context.Students.Skip(startIndex).Take(pageSize).ToList();
        return students;
    }
}
