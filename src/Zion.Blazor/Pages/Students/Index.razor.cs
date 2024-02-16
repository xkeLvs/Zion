using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Volo.Abp.Application.Dtos;
using Zion.Students;
using Zion.Students.Dtos;

namespace Zion.Blazor.Pages.Students;

public partial class Index
{
    private IEnumerable<StudentDto> students;

    [Inject]
    IStudentAppService studentAppService { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        await ReadData();
    }

    private async Task ReadData()
    {
        students = await studentAppService.GetAllListAsync();
        
    }
}
