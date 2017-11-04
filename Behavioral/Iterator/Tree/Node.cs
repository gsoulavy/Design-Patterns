namespace Behavioral.Iterator.Tree
{
    using static System.Math;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("Value: {Value}, Left: {HasLeft}, Right: {HasRight}")]
    public class Node<T> : IEnumerable<T>
    {
        public T Value { get; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public bool HasLeft => Left != null;

        public bool HasRight => Right != null;

        public bool IsLeftPriority => Left?.Depth() <= Right?.Depth();

        public void Add(T value)
        {
            if (!HasLeft)
            {
                Left = new Node<T>(value);
                return;
            }
            if (!HasRight)
            {
                Right = new Node<T>(value);
                return;
            }
            if (IsLeftPriority)
                Left.Add(value);
            else
                Right.Add(value);
        }

        public int Depth()
        {
            if (HasLeft && HasRight)
            {
                var max = Max((int)Left?.Depth(), (int)Right?.Depth());
                return ++max;
            }
            return 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NodeEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class NodeEnumerator<T> : IEnumerator<T>
    {
        private readonly Node<T> _nodes;
        private Node<T> _current;
        private Node<T> _previousStack;
        private Stack<Node<T>> _breadCrumb = new Stack<Node<T>>();

        public NodeEnumerator(Node<T> nodes)
        {
            _nodes = nodes;
        }
        public bool MoveNext()
        {
            if (_current == null)
            {
                Reset();
                _current = _nodes;
                return true;
            }
            if (_current.HasLeft)
                return TraverseLeft();
            if (_current.HasRight)
                return TraverseRight();
            return TraverseUpAndRight();
        }

        private bool TraverseLeft()
        {
            _breadCrumb.Push(_current);
            _current = _current.Left;
            return true;
        }

        private bool TraverseRight()
        {
            _breadCrumb.Push(_current);
            _current = _current.Right;
            return true;
        }

        private bool TraverseUpAndRight()
        {
            if (_breadCrumb.Any())
            {
                _previousStack = _current;
                while (true)
                {
                    _current = _breadCrumb.Pop();
                    if (_previousStack != _current.Right) break;
                }
                if (_current.HasRight)
                {
                    return TraverseRight();
                }
            }
            return false;
        }

        public void Reset()
        {
            _current = null;
        }

        public T Current => _current.Value;

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            
        }
    }
}