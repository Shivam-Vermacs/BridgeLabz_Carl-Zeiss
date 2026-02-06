using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Scenario_Based_Questions
{
    public class TestResult
    {
        public int TestId { get; set; }
        public int MachineId { get; set; }
        public long Timestamp { get; set; }
        public double ResultValue { get; set; }
    }

    internal class High_PrecisionOpticalTestingSystem
    {
        private HashSet<int> _testIds = new HashSet<int>();
        private Dictionary<int, LinkedList<TestResult>> _machineData = new Dictionary<int, LinkedList<TestResult>>();
        private Stack<TestResult> _undoStack = new Stack<TestResult>();
        private LinkedList<TestResult> _globalHistory = new LinkedList<TestResult>();

        private const long ExpirationTimeSeconds = 600;

        public bool AddTestResult(int testId, int machineId, long timestamp, double value)
        {
            CleanupExpired(timestamp);

            if (_testIds.Contains(testId))
            {
                return false;
            }

            var result = new TestResult
            {
                TestId = testId,
                MachineId = machineId,
                Timestamp = timestamp,
                ResultValue = value
            };

            _testIds.Add(testId);

            if (!_machineData.ContainsKey(machineId))
            {
                _machineData[machineId] = new LinkedList<TestResult>();
            }
            _machineData[machineId].AddLast(result);

            _undoStack.Push(result);
            _globalHistory.AddLast(result);

            return true;
        }

        public List<TestResult> GetLatestN(int machineId, int n)
        {
            if (!_machineData.ContainsKey(machineId)) return new List<TestResult>();
            return _machineData[machineId].TakeLast(n).ToList();
        }

        public void UndoLastInsertion()
        {
            if (_undoStack.Count == 0) return;

            var lastResult = _undoStack.Pop();

            _testIds.Remove(lastResult.TestId);

            if (_machineData.ContainsKey(lastResult.MachineId))
            {
                _machineData[lastResult.MachineId].RemoveLast();
            }

            _globalHistory.RemoveLast();
        }

        public void CleanupExpired(long currentTimestamp)
        {
            while (_globalHistory.Count > 0 && _globalHistory.First.Value.Timestamp < currentTimestamp - ExpirationTimeSeconds)
            {
                var expired = _globalHistory.First.Value;
                _globalHistory.RemoveFirst();

                _testIds.Remove(expired.TestId);

                if (_machineData.ContainsKey(expired.MachineId))
                {
                    _machineData[expired.MachineId].RemoveFirst();
                }
            }
        }
    }
}