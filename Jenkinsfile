pipeline {
	agent none
	
	environment {
		val1 = 'ola'
		branchname = '$(env.BRANCH_NAME)'
	}
	
	stages {
		stage('pre') {
			agent any
			steps {
				println ('NO BRANCH MAIN')		
			}
		}
		stage('checkout') {
			agent any
			steps {
				println 'branch->$(env.branchname)'
				checkout scm
				println 'RESULT->$(currentBuild.result)'
				junit '**/target/*.xml'
			}
		}
		stage('build') {
			agent any
			steps {
				println 'val1->$(env.val1)'
				println '$(env.BUILD_ID)->$(env.JOB_NAME):$(env.BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			println('Sucesso')
		}
	}
}


