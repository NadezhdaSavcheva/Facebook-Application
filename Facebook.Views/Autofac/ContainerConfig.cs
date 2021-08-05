using Autofac;
using Facebook.Services;
using Facebook.Services.DAO;

namespace Facebook.Views.Autofac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Welcome>().SingleInstance();
            builder.RegisterType<Registration>();
            builder.RegisterType<Profile>();
            builder.RegisterType<Login>();
            builder.RegisterType<HomePage>();
            builder.RegisterType<Groups>();
            builder.RegisterType<Friends>();
            builder.RegisterType<Events>();
            builder.RegisterType<EventsDAO>().As<IEventsDAO>();
            builder.RegisterType<FriendsDAO>().As<IFriendsDAO>();
            builder.RegisterType<GroupsDAO>().As<IGroupsDAO>();
            builder.RegisterType<HomeDAO>().As<IHomeDAO>();
            builder.RegisterType<PostsDAO>().As<IPostsDAO>();
            builder.RegisterType<ProfileDAO>().As<IProfileDAO>();
            builder.RegisterType<UserDAO>().As<IUserDAO>();

            builder.RegisterInstance<FacebookDBContext>(new FacebookDBContext());

            return builder.Build();
        }
    }
}
