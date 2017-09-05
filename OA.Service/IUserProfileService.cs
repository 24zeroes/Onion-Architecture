using OA.Data;

namespace OA.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}