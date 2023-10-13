namespace DesignPatternsBookChapter13
{
    public interface IPurchaseCommand
    {
        void ExecuteOperation();
        void RevertOperation();
    }
}

