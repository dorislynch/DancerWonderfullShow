
# react-native-dancer-wonderfull-show

## Getting started

`$ npm install react-native-dancer-wonderfull-show --save`

### Mostly automatic installation

`$ react-native link react-native-dancer-wonderfull-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-dancer-wonderfull-show` and add `RNDancerWonderfullShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDancerWonderfullShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDancerWonderfullShowPackage;` to the imports at the top of the file
  - Add `new RNDancerWonderfullShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-dancer-wonderfull-show'
  	project(':react-native-dancer-wonderfull-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-dancer-wonderfull-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-dancer-wonderfull-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDancerWonderfullShow.sln` in `node_modules/react-native-dancer-wonderfull-show/windows/RNDancerWonderfullShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Dancer.Wonderfull.Show.RNDancerWonderfullShow;` to the usings at the top of the file
  - Add `new RNDancerWonderfullShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDancerWonderfullShow from 'react-native-dancer-wonderfull-show';

// TODO: What to do with the module?
RNDancerWonderfullShow;
```
  