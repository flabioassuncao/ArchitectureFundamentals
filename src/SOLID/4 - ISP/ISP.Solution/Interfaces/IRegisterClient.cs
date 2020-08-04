namespace SOLID.ISP.Solution.Interfaces
{
    public interface IRegisterClient : IRegister
    {
        void Validate();
        void SendEmail();
    }
}
