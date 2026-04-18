

[Authorize(Roles = "Admin")]
[HttpGet]
public IActionResult GetData()
{
    return Ok("Admin Access");
}