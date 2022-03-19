public class InputUI :ISubscribe
{
    private readonly Data _data;
    public InputUI(Data data)
    {
        _data = data;
    }
   
    public void Subscribe()
    {
        _data._referance.UI.Parametrs.Subscribe();
        _data._referance.UI.Parametrs.ChangeDataEvent += InputValue;

    }

    private void InputValue(ParmentrsSpawn obj)
    {
        _data.DataUpDate(ref obj);
    }

    public void UnSubscribe()
    {
        _data._referance.UI.Parametrs.UnSubscribe();
        _data._referance.UI.Parametrs.ChangeDataEvent -= InputValue;
    }
}
