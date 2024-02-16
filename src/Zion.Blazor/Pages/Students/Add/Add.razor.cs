using System;
using Blazorise;
using System.IO;
using System.Threading.Tasks;
using Zion.Students.Dtos;
using Microsoft.AspNetCore.Components;
using Zion.Students;

namespace Zion.Blazor.Pages.Students.Add;

public partial class Add
{

    DatePicker<DateTime?>? datePicker;

    DateTime? value;

    public CreateStudentDto createStudentDto { get; set; }

    [Inject]
    public IStudentAppService studentAppService { get; set; }

    bool successVisible = false;
    bool warningVisible = false;
    Validations Validations;

    protected override void OnInitialized()
    {
        createStudentDto = new();
    }

    public async Task OnFileUpload(FileUploadEventArgs e)
    {
        try
        {
            using (MemoryStream result = new MemoryStream())
            {
                await e.File.OpenReadStream(long.MaxValue).CopyToAsync(result);
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    async Task Submit()
    {
        successVisible = false;
        warningVisible = false;
        if (await Validations.ValidateAll())
        {
            // create function for adding student  
            await studentAppService.CreateAsync(createStudentDto);
            createStudentDto = new();
            await Validations.ClearAll();
            successVisible = true;
        }else {
            warningVisible = true;
        }
    }


}
