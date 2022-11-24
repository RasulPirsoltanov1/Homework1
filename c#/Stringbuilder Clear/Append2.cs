class BuilderString
{
    public char[] _arr;
    private char[] _arrRemoved=new char[43];
    private string text=String.Empty;
    public int Capacity { get; set; }
    public BuilderString()
    {
        Capacity = 0;
        _arr = new char[Capacity];
    }
    public BuilderString Append(string symbol)
    {
        BuilderString result = new();
        for (int i = 0; i < symbol.Length; i++)
        {
            Append(symbol[i]);
            result.Append(_arr[i]);
        }
        return result;
    }
    public void Remove(char symbol)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            if(_arr[i] == symbol)
            {
                _arrRemoved[i]='\0';
                text += '\0';
            }
            else
            {
                _arrRemoved[i] = _arr[i];
                text+= _arr[i];
            }
        }
        for(int i = 0; i < Capacity; i++)
        {
            if (text[i] != '\0')
            {
                _arr[i] = text[i];
            }
            else
            {
                _arr[i] = '\0';
            }
        }
        
    }
    public void Append(char symbol)
    {
        if (Capacity == 0)
        {
            Capacity = 16;
            Array.Resize(ref _arr, Capacity);
        }
        if (_arr[Capacity - 1] != 0)
        {
            Capacity *= 2;
            Array.Resize(ref _arr, Capacity);
            _arr[Capacity / 2] = symbol;
            return;
        }

        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0)
            {
                _arr[i] = symbol;
                break;
            }

        }
    }

    public BuilderString Replace(char oldVal, char newVal)
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0)
            {
                break;
            }
            if (_arr[i] == oldVal)
            {
                _arr[i] = newVal;
            }
        }
        return this;
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (char item in _arr)
        {
            if (item == 0) break;
            result += item;
        }
        return result;
    }


}