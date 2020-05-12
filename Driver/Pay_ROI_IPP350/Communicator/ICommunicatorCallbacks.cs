namespace PAY_ROI_IPP350.Communicator
{
    public interface ICommunicatorCallbacks
    {
        void InitRequest(object parameters);

        void TestRequest(object parameters);

        void PayRequest(object parameters);
    }
}
