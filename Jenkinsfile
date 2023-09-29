pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout the source code from the repository
                script {
                    checkout scm
                }
            }
        }

        stage('Build') {
            steps {
                // Use the Unity3D plugin to build the Unity project
                unity3dBuild(
                    projectName: 'test',
                    unityVersion: '2022.3.8f1',
                    targetPlatform: 'WindowsStandalone',
                    buildName: 'test',
                    buildPath: 'Builds',  // Change this to your desired build path
                    // executeMethod: 'YourBuildMethod'  // Optional: specify a custom build method
                )
            }
        }
    }
}
