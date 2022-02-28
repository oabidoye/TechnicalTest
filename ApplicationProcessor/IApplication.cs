using Ulaw.ApplicationProcessor.Models;

namespace Ulaw.ApplicationProcessor
{
    public interface IApplication
    {
        string Process(ApplicationRequestModel requestModel);
    }
}
