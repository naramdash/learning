# 도메인 주도 설계란

개발자는 소프트웨어를 통해 문제를 해결하는 직업.

도메인 주도 설계, 데이터베이스 주도 설계, 객체 지향 설계을 구분할 수 있도록 하자.

도메인 주도 설계은 개발자가 비기술팀과 협업할 때 특히 유용하다.

## 공유 모델의 중요성

문제를 제대로 이해하는 것이 중요하다.

개발자와 도메인 전문가가 계속 협엽할 수 있을까?

서로 해석이 필요 없는 공유 멘탈 모델을 모두가 공유하자!

### 공유 멘탈 모델의 장점

- 더 빨리 솔루션을 구현할 수 있다
- 더 문제를 잘 풀어내는 솔루션을 만들 수 있다
- 불필요한 낭비를 줄인다
- 유지보수와 추가 개발이 쉽다

### 공유 멘탈 모델을 개발하려면

- 비지니스 이벤트와 워크플로우에 집중하자, 데이터 구조가 아니라
- 도메인을 잘게 쪼갠다
- 나누어진 도메인에 모델을 만든다
- 문서와 대화, 코드에 모두 사용되는 공용 언어를 통해 개발한다

## 비지니스 이벤트를 통해 도메인 이해하기

비지니스란 데이터 구조가 아니라, 데이터의 변천과정이다

데이터 변화의 시작은 바깥에서 일어날수도, 시간마다 일어날수도, 그외에도 여러가지 일어날 수 있다

데이터 변화의 시작을 도메인 이벤트라고 부른다

도메인 이벤트를 기반으로 모델을 작성하기 시작한다

도메인 이벤트는 언제나 과거형이다. 왜냐하면 과거에 일어난 바꿀 수 없는 "사실"이기 때문이다

### 이벤트 스토밍으로 도메인 탐험하기

이벤트 스토밍: 비지니스 이벤트와 워크플로우를 발견하기 위한 협동 프로세스

### 도메인 탐험하기

이벤트 스토밍을 통해 다음과 같은 일을 달성한다

- 비지니스에 대한 공유 모델
- (모든)다른 팀들에 대한 인식
- 요구사항과의 갭 발견
- 팀 간의 연결 관계를 발견
- Reporting 구간 요구사항 인식

### 이벤트를 끝까지 확장하기

시스템의 경계까지 이벤트를 연속하여 발견하기

도메인 전문가가 어떻게 일을 처리해왔는가를 이해하는 것은 중요하다

어떤 매개체를 썼는가보다는, 어떻게 처리했는가가 중요하다

모든 처리과정을 한번에 바꿀 필요는 없다

### 용어 정리

- 시나리오: 유저가 달성하고자 하는 것
- 유즈케이스: 구체적인 시나리오 구현법
- 비지니스 프로세스: 비지니스가 달성하고자 하는 것
- 워크플로우: 구체화된 비지니스 프로세스. 팀 혹은 구성원이 처리해야할 단계로 구성되어 있으며, 팀 혹은 개인의 범위를 넘어서지 않도록 범위가 제한된다.

### 커맨드 문서화

도메인 이벤트를 발생시키는 것을 커맨드라고 한다.

커맨드는 누군가, 어떤 것이 일어나기를 원하기에 일어난다, 그래서 명령적이다

커맨드가 항상 성공하지는 않지만 성공하면 이벤트를 발생시키며, 워크플로우가 시작된다.

또한 이벤트는 커맨드를 발생시킨다. 이는 매우 함수형 프로그래밍과 비슷하다.

모든 이벤트가 커맨드에 의해 발생하는 것은 아니다, 주기적으로 또는 모니터링에 의해 발생할 수 있기 때문. (월간정산, 품절)

## 도메인 잘게 쪼개기

비지니스에 각각의 부서가 존재한다는 것은 전체 도메인을 쪼개는데 있어 큰 힌트가 된다.

쪼개진 도메인을 (서브) 도메인이라고 하자.

도메인은 한 도메인 전문가가 활약할 수 있는 공간이다.

ex) 도메인: 과학, 서브도메인: 물리

서브도메인은 서로 겹치는 영역이 많으므로 조심해야한다.

솔루션을 개발하고 싶다면 도메인 전문가가 되야한다.

## 나누어진 문맥에 솔루션 만들기

솔루션은 도메인 전체를 표현할 수도 없으며, 우리는 그렇게 하고싶지도 않다.

문제를 해결하기 위한 정보에 집중해야하며, 나머지는 군더더기다.

문제 영역과 해결 역역으로 분리하고, 다르게 취급해야한다.

문제 영역을 해결하기 위해 문제 영역을
