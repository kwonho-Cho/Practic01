using System;

namespace LearnCS5
{
    class Person
    {
        string _Name;
        public bool _IsSex;

        string _txtGender;

        public Person()
        {
            Console.WriteLine("생성자가 호출 되었습니다!!");
        }
        //설정 함수(초기화 이후 개별 변수의 설정을 변화시킬때)
        private void SettingGenderText(bool gender)
        {
            if (gender)
            {
                _txtGender = "남자";
            }
            else
            {
                _txtGender = "여자";
            }
        }

        //초기화 함수(변수 다수의 값을 초기화할떄)
        public void InitData(string name, bool gender)
        {
            _Name = name;
            _IsSex = gender;

            //gender변수가 반복해서 쓰일경우 받아오는 부분에서 결정시켜준다

            SettingGenderText(_IsSex);
            //if (_IsSex)
            //{
            //    _txtGender = "남자";
            //}
            //else
            //{
            //    _txtGender = "여자";
            //}
        }
        //외부에서 이름 설정
        public void SetName(string name)
        {
            _Name = name;
        }
        //외부에 이름 반환 (get, set 논리)
        public string GetName()
        {
            return _Name;
        }

        public void SetGender(bool gender)
        {
            _IsSex = gender;
            SettingGenderText(gender);
        }
        //gender의 형식인 bool값과 string값을 둘 다 원할 때 가져오기 위함
        public bool GetGender()
        {
            return _IsSex;
        }
        public string GetGenderText()
        {
            return _txtGender;
        }

        public void ShowInfo()
        {
            Console.WriteLine("내 이름은 {0}입니다.");
            Console.WriteLine("{0}입니다", _txtGender);
            
        }

        public void Laugh()
        {
            if (_IsSex)
            {
                Console.WriteLine("하하하");
            }
            else
            {
                Console.WriteLine("호호호");
            }
        }
    }
}
