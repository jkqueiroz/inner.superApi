using Abp.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Upload
{
    internal interface IUploadService : IApplicationService
    {
        Task<ActionResult> Upload([FromForm] ICollection<IFormFile> files);
    }
}
