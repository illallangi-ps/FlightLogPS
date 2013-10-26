using System.Management.Automation;
using Illallangi.FlightLogPS.Model;

namespace Illallangi.FlightLogPS.PowerShell
{
    [Cmdlet(VerbsCommon.Add, Nouns.City)]
    public sealed class AddCityCmdlet : ZumeroCmdlet<ICitySource>
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string CountryName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            this.WriteObject(this.Repository.CreateCity(this.Name, this.CountryName));
        }
    }
}