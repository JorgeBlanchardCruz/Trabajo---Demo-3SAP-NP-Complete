namespace Demo_3SAP_NP_Complete {
    public class CLiteral {

        private int _id;
        private bool? _value;
        private static int _lastAssignedId = 0;

        private CLiteral (int id) {
            setId(id);
            setValue(null);
        }

        private CLiteral (int id, bool value) {
            setId(id);
            setValue(value);
        }

        private void setId (int id) {
            this._id = id;
        }

        public void setValue (bool? value) {
            this._value = value;
        }

        public bool equals (object obj) {
            return this.getId() == ((CLiteral) obj).getId();
        }

        public static CLiteral generateLiteral () {
            return new CLiteral(_lastAssignedId++);
        }

        public static CLiteral generateLiteral (bool value) {
            return new CLiteral(_lastAssignedId++, value);
        }

        public string toString () {
            return getId() + " ";
        }

        public int getId () {
            return _id;
        }

        public bool isTrue () {
            return (_value == null ? false : (bool)_value);
        }



    }
}
