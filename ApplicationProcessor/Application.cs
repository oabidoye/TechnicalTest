using System.Text;
using Ulaw.ApplicationProcessor;
using Ulaw.ApplicationProcessor.Extensions;
using Ulaw.ApplicationProcessor.Models;
using ULaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor
{
    public class Application : IApplication
    {
        public string Process(ApplicationRequestModel requestModel)
        {
            var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");

            switch (requestModel.DegreeGrade)
            {
                case DegreeGradeEnum.twoTwo:
                    result.Append($"<p> Dear {requestModel.FirstName}, </p>");
                    result.Append($"<p/> Further to your recent application for our course reference: {requestModel.CourseCode} starting on {requestModel.StartDate.ToLongDateString()}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.");
                    result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
                    result.Append("<br/> Yours sincerely,");
                    result.Append("<p/> The Admissions Team,");
                    break;
                case DegreeGradeEnum.third:
                    result.Append($"<p> Dear {requestModel.FirstName}, </p>");
                    result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
                    result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
                    result.Append("<br> Yours sincerely,");
                    result.Append("<p/> The Admissions Team,");
                    break;
                default:
                    {
                        if (requestModel.DegreeSubject == DegreeSubjectEnum.law || requestModel.DegreeSubject == DegreeSubjectEnum.lawAndBusiness)
                        {
                            decimal depositAmount = 350.00M;

                            result.Append($"<p> Dear {requestModel.FirstName}, </p>");
                            result.Append($"<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {requestModel.CourseCode} starting on {requestModel.StartDate.ToLongDateString()}.");
                            result.Append($"<br/> This offer will be subject to evidence of your qualifying {requestModel.DegreeSubject.ToDescription()} degree at grade: {requestModel.DegreeGrade.ToDescription()}.");
                            result.Append($"<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{depositAmount} deposit fee to secure your place.");
                            result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));
                            result.Append(string.Format("<br/> Yours sincerely,"));
                            result.Append(string.Format("<p/> The Admissions Team,"));
                        }
                        else
                        {
                            result.Append($"<p> Dear {requestModel.FirstName}, </p>");
                            result.Append($"<p/> Further to your recent application for our course reference: {requestModel.CourseCode} starting on {requestModel.StartDate.ToLongDateString()}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.");
                            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
                            result.Append("<br/> Yours sincerely,");
                            result.Append("<p/> The Admissions Team,");
                        }

                        break;
                    }
            }

            result.Append(string.Format("</body></html>"));

            return result.ToString();
        }
    }
}

