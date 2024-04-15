
# react-native-funny-life-of-mechanic

## Getting started

`$ npm install react-native-funny-life-of-mechanic --save`

### Mostly automatic installation

`$ react-native link react-native-funny-life-of-mechanic`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-funny-life-of-mechanic` and add `RNFunnyLifeOfMechanic.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNFunnyLifeOfMechanic.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNFunnyLifeOfMechanicPackage;` to the imports at the top of the file
  - Add `new RNFunnyLifeOfMechanicPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-funny-life-of-mechanic'
  	project(':react-native-funny-life-of-mechanic').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-funny-life-of-mechanic/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-funny-life-of-mechanic')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNFunnyLifeOfMechanic.sln` in `node_modules/react-native-funny-life-of-mechanic/windows/RNFunnyLifeOfMechanic.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Funny.Life.Of.Mechanic.RNFunnyLifeOfMechanic;` to the usings at the top of the file
  - Add `new RNFunnyLifeOfMechanicPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNFunnyLifeOfMechanic from 'react-native-funny-life-of-mechanic';

// TODO: What to do with the module?
RNFunnyLifeOfMechanic;
```
  