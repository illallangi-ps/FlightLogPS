namespace Illallangi.FlightLog.PowerShell.Timezone
{
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Remove, Nouns.Timezone, SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public sealed class RemoveTimezoneCmdlet : FlightLogRemoveCmdlet<ITimezone>
    {
        #region Primary Key Property

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public int? Id { get; set; }

        #endregion

        #region Instance Properties

        [SupportsWildcards]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        #endregion
    }
}