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
				echo ('NO BRANCH MAIN')		
			}
		}
		stage('checkout') {
			agent any
			steps {
				echo 'branch->$(env.branchname)'
				checkout scm
				echo 'RESULT->$(currentBuild.result)'
			}
		}
		stage('build') {
			agent any
			steps {
				echo 'val1->$(env.val1)'
				echo '$(env.BUILD_ID)->$(env.JOB_NAME):$(env.BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			echo 'Sucesso'
		}
	}
}


