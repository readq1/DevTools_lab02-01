using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using Wintellect.PowerCollections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wintellect.PowerCollections.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Capacity_must_be_equal_value_passed_to_constructor()//Test Capacity
        {
            Stack<int> stack = new Stack<int>(10);
            Assert.AreEqual(10, stack.Capacity);
        }
        [TestMethod]
        public void IsEmpty_must_be_true_in_empty_stack_and_must_be_false_in_full_stack()//Test IsEmpty
        {
            Stack<int> stack = new Stack<int>(10);
            Assert.IsTrue(stack.IsEmpty);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            Assert.IsFalse(stack.IsEmpty);
        }
        [TestMethod]
        public void Count_must_be_zero_with_an_empty_stack()//Test Count
        {
            Stack<int> stack = new Stack<int>(10);
            Assert.AreEqual(0, stack.Count);
        }
        [TestMethod]
        public void Count_must_be_equal_to_push_elements()//Test Count
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            Assert.AreEqual(3, stack.Count);
        }
        
        [TestMethod]
        public void Push_by_calling_must_be_place_element_on_top_of_stack_and_increase_count()//Test Push
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(7, stack.Pop());
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Push_when_stack_overflows_should_throw_exeption()//Test Push
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
        }
        [TestMethod]
        public void Pop_when_calling_should_return_element_from_top_stack_and_change_count()//Test Pop
        {
            Stack<int> stack = new Stack<int>(5);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_when_calling_stack_is_empty_should_throw_exeption()//Test Pop
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
        }
        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void Negative_parametr_should_throw_exeption()
        {
            Stack<int> stack = new Stack<int>(-10);
        }
    }
}

