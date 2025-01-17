fn prints_and_returns_10 (a:i32) -> i32 {
    println!("i got the value {}", a);
    10
}

pub fn add_two(a: i32) -> i32 {
    a + 2
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn this_test_will_pass() {
        let value = prints_and_returns_10(4);
        assert_eq!(10, value);
    }

    #[test]
    fn this_test_will_fail() {
        let value = prints_and_returns_10(8);
        assert_eq!(5, value);
    }

    #[test]
    fn add_2_and_2() {
        assert_eq!(4, add_two(2))
    }
    #[test]
    fn add_2_and_3() {
        assert_eq!(5, add_two(3))
    }
    #[test]
    fn add_2_and_100() {
        assert_eq!(102, add_two(100))
    }

    #[test]
    fn it_works() {
        assert_eq!(2 + 2, 5);
    }

    #[test]
    #[ignore]
    // ignore to ignore this test from normal test
    fn expensive_test() {
        // very expansive...
    }
}