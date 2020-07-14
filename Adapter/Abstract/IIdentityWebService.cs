namespace Adapter
{
    public interface IIdentityWebService
    {
        CitizenWebService TcNumberQuestioning(char[] tcNumber);
        bool CriminalRecordQuestioning(char[] tcNumber);
        int AgeQuestioning(char[] tcNumber);
    }
}