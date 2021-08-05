using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IProfileDAO
    {
        void CustomizeProfile(Profiles userProfile);
        int DeleteProfileByID(int profileId);
    }
}