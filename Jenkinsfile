pipeline {
    agent any

    stages {
        stage('Build'){
            steps{
                bat 'git log'
                bat 'dotnet build'
                step([$class: 'Mailer', notifyEveryUnstableBuild: true, recipients: 'kunalrust@gmail.com', sendToIndividuals: true])
            }
        }
        stage('Unit Test'){
            steps{
	            bat 'dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover'
                step([$class: 'Mailer', notifyEveryUnstableBuild: true, recipients: 'kunalrust@gmail.com', sendToIndividuals: false])
            }
        }
        stage('Code Coverage'){
            steps{
                publishCoverage adapters: [opencoverAdapter(path: '**\\FirstcoreProject\\coverage.opencover.xml', thresholds: [[failUnhealthy: true, thresholdTarget: 'Line', unhealthyThreshold: 80.0, unstableThreshold: 80.0]])], sourceFileResolver: sourceFiles('NEVER_STORE')
                step([$class: 'Mailer', notifyEveryUnstableBuild: true, recipients: 'kunalrust@gmail.com', sendToIndividuals: false])
            }
        }
        stage('Publish'){
            steps{
                bat 'dotnet publish'
            }
        }
        stage('Run'){
            steps{
                bat 'cd FirstCoreProject'
                bat 'dotnet run --project FirstCoreProject'
            }
        }
    }
}