namespace ListInt_Struct
{
    internal class ListInt
    {
        private int[] _arr;

        public int Length
        {
            get { return _arr.Length; }
        }

        public int this[int index]
        {
            get
            {
                if (index >= _arr.Length || index < 0)
                {
                    return -1;
                }
                return _arr[index];
            }
            set
            {
                if (index >= 0 && index < _arr.Length)
                {
                    _arr[index] = value;
                }
            }
        }

        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(params int[] nums)
        {
            _arr = new int[nums.Length];
            nums.CopyTo(_arr, 0);
        }

        public ListInt(int length)
        {
            _arr = new int[length];
        }

        public void Add(int value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
        public override string ToString()
        {
            return string.Join(" ", _arr);
        }

        public int Sum()
        {
            int total = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                total += _arr[i];
            }
            return total;
        }

        public void AddRange(params int[] nums)
        {
            int newSize = _arr.Length + nums.Length;
            Array.Resize(ref _arr, newSize);

            for (int i = 0; i < nums.Length; i++)
            {
                _arr[_arr.Length - nums.Length + i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(int num)
        {
            int index = Array.IndexOf(_arr, num);
            if (index == -1) return false;

            for (int i = index; i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            Array.Resize(ref _arr, _arr.Length - 1);
            return true;
        }

        public void RemoveRange(params int[] nums)
        {
            foreach (var num in nums)
            {
                Remove(num);
            }
        }
    }
}
